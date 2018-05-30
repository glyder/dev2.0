import { Component, OnInit } from '@angular/core';

import { ToastService } from '@vrs/typescripts/pro/alerts/toast/toast.service';

@Component({
  selector: 'vrs-mdb-buttons',
  templateUrl: './mdb-buttons.component.html',
  styleUrls: ['./mdb-buttons.component.scss']
})
export class MdbButtonsComponent implements OnInit {

  singleModel: any;
  isCollapsed = false;

  constructor(private toastrService: ToastService) { }


  showInfo() {
    this.toastrService.info('Success message');
  }

  showWarning() {
    this.toastrService.warning('Error message');
  }

  ngOnInit() {
  }

}
