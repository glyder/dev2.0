  import { Component, OnInit,
    Input, Output, EventEmitter } from '@angular/core';

@Component({
selector: 'vrs-button',
templateUrl: './button.component.html',
styleUrls: ['./button.component.scss']
})
export class ButtonComponent implements OnInit {

// tslint:disable-next-line:no-inferrable-types
@Input() complete: boolean = true;

@Input() label: string;
@Input() id: string;
@Input() btnCss: string;
@Input() icon: string;

@Output() onclick = new EventEmitter();

constructor() { }

ngOnInit() {
// console.log('button running');
}

buttonClick() {
this.onclick.emit(this.id);
}

}

/* Examples:

<app-button label="Login"
     btnCss="btn btn-default waves-light"
     icon="fa-key"
     id="login"
     [complete]="complete"
     (onclick)="login($event)"></app-button>

complete: boolean;

ngOnInit() {
this.complete = true;
}

login(id: string) {
this.complete = false;
console.log('login clicked!');
}

*/
