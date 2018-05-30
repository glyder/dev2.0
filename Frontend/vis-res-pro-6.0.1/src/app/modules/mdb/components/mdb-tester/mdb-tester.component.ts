import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'vrs-mdb-tester',
  templateUrl: './mdb-tester.component.html',
  styleUrls: ['./mdb-tester.component.scss']
})
export class MdbTesterComponent implements OnInit {

  hideElement = true;

  addtags: string[]  = [];
  initialtags: string[] = ['Tag 1', 'Tag 2', 'Tag 3'];
  placeholderVar = 'Your placeholder';

  constructor() { }

  ngOnInit() {
  }

}
