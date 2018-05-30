import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'vrs-material-tester',
  templateUrl: './material-tester.component.html',
  styleUrls: ['./material-tester.component.scss']
})
export class MaterialTesterComponent implements OnInit {

  answer = '';
  answerDisplay = '';
  showSpinner = false;

  constructor() { }

  showAnswer() {
    this.showSpinner = true;

    setTimeout(() => {
      this.answerDisplay = this.answer;
      this.showSpinner = false;
    }, 2000);
  }

  ngOnInit() {
  }

}
