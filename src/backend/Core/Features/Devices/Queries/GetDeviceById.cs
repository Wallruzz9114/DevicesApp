using AutoMapper;
using Data.DTOs;
using Data.Interfaces;
using MediatR;

namespace Core.Features.Devices.Queries
{
    public class GetDeviceById
    {
        public class Query : IRequest<DeviceDetailsDTO>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, DeviceDetailsDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<DeviceDetailsDTO> Handle(Query query, CancellationToken cancellationToken)
            {
                var deviceFromDb = await _unitOfWork.Devices.GetByIdAsync(query.Id);

                if (deviceFromDb is not null)
                {
                    var deviceToReturn = _mapper.Map<DeviceDetailsDTO>(deviceFromDb);
                    return deviceToReturn;
                }

                throw new Exception($"Couldn't find device with id: { query.Id }");
            }
        }
    }
}