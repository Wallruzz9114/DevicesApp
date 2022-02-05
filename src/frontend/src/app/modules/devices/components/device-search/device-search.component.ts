import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { faSearch } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-device-search',
  templateUrl: './device-search.component.html',
  styleUrls: ['./device-search.component.scss'],
})
export class DeviceSearchComponent implements OnInit {
  @Output() public onSearch: EventEmitter<string> = new EventEmitter();
  @ViewChild('searchInput') public searchInput!: ElementRef;

  public faSearch = faSearch;

  constructor() {}

  ngOnInit(): void {}

  public onTyping = (event: any): void => {
    this.onSearch.emit(event.target.value);
  };

  public clearInput = (): void => {
    this.searchInput.nativeElement.value = '';
  };
}
