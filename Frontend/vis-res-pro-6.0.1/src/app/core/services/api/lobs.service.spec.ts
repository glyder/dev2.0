import { TestBed, inject } from '@angular/core/testing';

import { LOBsService } from './lobs.service';

describe('LOBsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LOBsService]
    });
  });

  it('should be created', inject([LOBsService], (service: LOBsService) => {
    expect(service).toBeTruthy();
  }));
});
