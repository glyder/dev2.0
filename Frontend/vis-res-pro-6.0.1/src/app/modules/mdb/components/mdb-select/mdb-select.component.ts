import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'vrs-mdb-select',
  templateUrl: './mdb-select.component.html',
  styleUrls: ['./mdb-select.component.scss']
})
export class MdbSelectComponent implements OnInit {

  optionsSelect: Array<any>;

  dateOptionsSelect= [
    { value: '1', label: 'Today', selected: true },
    { value: '2', label: 'Yesterday' },
    { value: '3', label: 'Last 7 days' },
    { value: '4', label: 'Last 30 days' },
    { value: '5', label: 'Last week' },
    { value: '6', label: 'Last month' }
  ];
  selectedValue = '1';

  constructor() { }

  ngOnInit() {
    this.optionsSelect = [
      { value: '1', label: 'Option 1' },
      { value: '2', label: 'Option 2' },
      { value: '3', label: 'Option 3' },
    ];
  }

}
