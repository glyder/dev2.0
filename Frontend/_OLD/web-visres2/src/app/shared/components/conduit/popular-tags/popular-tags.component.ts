import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ApiTagsService, ApiUserService } from '@vrs/core/services';
import { ArticleListConfig } from '@vrs/models/test';

import { fadeInAnimation } from '@vrs/shared/animations';

@Component({
  selector: 'app-popular-tags',
  templateUrl: './popular-tags.component.html',
  styleUrls: ['./popular-tags.component.scss'],
  animations: [fadeInAnimation]
})
export class PopularTagsComponent implements OnInit {

  constructor( private router: Router,
              private tagsService: ApiTagsService,
              private userService: ApiUserService) {

  }


  // Authentication
  isAuthenticated: boolean;

  // ArticleListConfig
  listConfig: ArticleListConfig = {
    type: 'all',
    filters: {}
  };

  // Tags
  tags: Array<string> = [];
  tagsLoaded = false;

  ngOnInit() {

    // Authentication
    this.userService
        .isAuthenticated
        .subscribe((authenticated) => {
                    this.isAuthenticated = authenticated;

                    // set the article list accordingly
                    if (authenticated) {
                      this.setListTo('feed');
                    } else {
                      this.setListTo('all');
                    }
                  }
    );

    // Get Tags (service)
    this.tagsService
        .getAll()
        .subscribe(tags => {
          this.tags = tags;
          this.tagsLoaded = true;
        });
  }

  setListTo(type: string = '', filters: Object = {}) {
    // If feed is requested but user is not authenticated, redirect to login
    if (type === 'feed' && !this.isAuthenticated) {
      this.router.navigateByUrl('/login');
      return;
    }

    // Otherwise, set the list object
    this.listConfig = {type: type, filters: filters};
  }

}
