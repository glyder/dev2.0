import { TestBed, inject } from '@angular/core/testing';

import { ApiArticlesService } from './api-articles.service';

describe('ApiArticlesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ApiArticlesService]
    });
  });

  it('should be created', inject([ApiArticlesService], (service: ApiArticlesService) => {
    expect(service).toBeTruthy();
  }));
});
