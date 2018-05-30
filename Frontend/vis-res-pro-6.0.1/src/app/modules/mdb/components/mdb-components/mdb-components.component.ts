import { Component, OnInit } from '@angular/core';

import { ToastService } from '@vrs/typescripts/pro/alerts/toast/toast.service';

@Component({
  selector: 'vrs-mdb-components',
  templateUrl: './mdb-components.component.html',
  styleUrls: ['./mdb-components.component.scss']
})
export class MdbComponentsComponent implements OnInit {

  constructor(private toastrService: ToastService) { }

  ngOnInit() {
  }

  public isOpenChange(): void { this.toastrService.success('isOpenChange triggered!'); }

    public onHidden(): void { this.toastrService.info('onHidden triggered!'); }

    public onShown(): void { this.toastrService.warning('OnShown triggered!'); }

}
