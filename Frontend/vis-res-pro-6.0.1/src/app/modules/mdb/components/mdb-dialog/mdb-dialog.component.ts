import { Component, ViewChild} from '@angular/core';

import { ModalDirective } from '@vrs/typescripts/free/modals/modal.directive';

@Component({
  selector: 'vrs-mdb-dialog',
  templateUrl: './mdb-dialog.component.html',
  styleUrls: ['./mdb-dialog.component.scss']
})
export class MdbDialogComponent {

    @ViewChild('autoShownModal') public autoShownModal: ModalDirective;
    public isModalShown = true;

    constructor() {
      this.isModalShown = true;
      // this.autoShownModal.show();
      // basicModal.show();
    }

    public showModal(): void {
        this.isModalShown = true;
    }

    public hideModal(): void {
        this.autoShownModal.hide();
    }

    public onHidden(): void {
        this.isModalShown = false;
    }
}
