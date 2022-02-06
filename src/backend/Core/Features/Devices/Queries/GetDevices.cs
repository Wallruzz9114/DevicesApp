using AutoMapper;
using Data.DTOs;
using Data.Interfaces;
using MediatR;

namespace Core.Features.Devices.Queries
{
    public class GetDevices
    {
        public class Query : IRequest<IEnumerable<DeviceDTO>> { }

        public class Handler : IRequestHandler<Query, IEnumerable<DeviceDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<IEnumerable<DeviceDTO>> Handle(Query query, CancellationToken cancellationToken)
            {
                var devicesFromDb = await _unitOfWork.Devices.GetAll();

                if (devicesFromDb is not null)
                {
                    var devicesToReturn = _mapper.Map<List<DeviceDTO>>(devicesFromDb);
                    return devicesToReturn;
                }

                throw new Exception($"Couldn't find any device");
            }
        }
    }
}