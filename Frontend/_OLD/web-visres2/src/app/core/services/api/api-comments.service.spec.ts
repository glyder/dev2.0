import { TestBed, inject } from '@angular/core/testing';

import { ApiCommentsService } from './api-comments.service';

describe('ApiCommentsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ApiCommentsService]
    });
  });

  it('should be created', inject([ApiCommentsService], (service: ApiCommentsService) => {
    expect(service).toBeTruthy();
  }));
});
