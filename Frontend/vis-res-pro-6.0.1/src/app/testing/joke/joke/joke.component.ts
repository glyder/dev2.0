import { Component, OnInit,
         EventEmitter, Input, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'vrs-joke',
  templateUrl: './joke.component.html',
  styleUrls: ['./joke.component.scss']
})
export class JokeComponent implements OnInit {

  // tslint:disable-next-line:no-input-rename
  @Input('joke') data: Joke;
  @Output() jokeDeleted = new EventEmitter<Joke>();

  constructor() {
  }

  deleteItem() {
    this.jokeDeleted.emit(this.data);
  }

  ngOnInit() {
  }

}