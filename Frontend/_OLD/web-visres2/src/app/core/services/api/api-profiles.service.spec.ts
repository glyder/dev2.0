import { TestBed, inject } from '@angular/core/testing';

import { ApiProfilesService } from './api-profiles.service';

describe('ApiProfilesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ApiProfilesService]
    });
  });

  it('should be created', inject([ApiProfilesService], (service: ApiProfilesService) => {
    expect(service).toBeTruthy();
  }));
});
