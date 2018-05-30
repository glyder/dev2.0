import { Component, OnInit } from '@angular/core';
// import { HttpClient } from '@angular/common/http';

// import { Observable } from 'rxjs/Observable';
// import { share } from 'rxjs/operators';

@Component({
  selector: 'vrs-kendo-tester',
  templateUrl: './kendo-tester.component.html',
  styleUrls: ['./kendo-tester.component.scss']
})
export class KendoTesterComponent implements OnInit {

  title = 'blank title';

  // public result$: Observable<any>;

  constructor() { // private httpClient: HttpClient) {

    // this.result$ = this.httpClient.get('http://api.github.com/users/hbrotan')
    //                               .pipe(share());
  }

  ngOnInit() {
  }

  // =====================================================
  // Events

  onButtonClick() {
    this.title = 'Hello from Kendo UI!';
  }

}
