import { Component, OnInit } from '@angular/core';

import { Store } from '@ngrx/store';
import { Observable } from 'rxjs/Observable';

// Post.reducer
import { Post } from '@vrs/store';
import * as PostActions from '@vrs/store/post/post.actions';

// Simple.reducer
import { SPANISH, FRENCH, AUSSIE } from '@vrs/store';

interface AppState {
  message: string;
  post: Post;
}

@Component({
  selector: 'app-ngrx',
  templateUrl: './ngrx.component.html',
  styleUrls: ['./ngrx.component.scss']
})
export class NgrxComponent implements OnInit {

  message$: Observable<string>;

  post$: Observable<Post>;
  text: string;             // form input val

  constructor(private store: Store<AppState>) {
     this.message$ = this.store.select('message');
     this.post$ = this.store.select('post');
   }

  ngOnInit() {
  }

  // ========================================================
  // Post reducer

  editText() { this.store.dispatch(new PostActions.EditText(this.text)); }
  resetPost() { this.store.dispatch(new PostActions.Reset()); }
  upvote() { this.store.dispatch(new PostActions.Upvote());  }
  downvote() { this.store.dispatch(new PostActions.Downvote()); }

  // ==============================
  // Simple Reducer

  spanishMessage() { this.store.dispatch({type: SPANISH}); }
  frenchMessage() { this.store.dispatch({type: FRENCH}); }
  aussieMessage() { this.store.dispatch({type: AUSSIE}); }
}
