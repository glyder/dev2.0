import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ng-material',
  templateUrl: './ng-material.component.html',
  styleUrls: ['./ng-material.component.scss']
})
export class NgMaterialComponent implements OnInit {

  title: '';

  // tslint:disable-next-line:no-inferrable-types
  answer: string = '';
  // tslint:disable-next-line:no-inferrable-types
  answerDisplay: string = '';
  // tslint:disable-next-line:no-inferrable-types
  showSpinner: boolean = false;

  constructor() { }

  ngOnInit() {
    
  }

  showAnswer() {
    this.showSpinner = true;

    setTimeout(() => {
      this.answerDisplay = this.answer;
      this.showSpinner = false;
    }, 2000);
  }

}
