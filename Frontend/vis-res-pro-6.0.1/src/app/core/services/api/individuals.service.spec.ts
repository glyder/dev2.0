import { TestBed, inject } from '@angular/core/testing';

import { IndividualsService } from './individuals.service';

describe('IndividualsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IndividualsService]
    });
  });

  it('should be created', inject([IndividualsService], (service: IndividualsService) => {
    expect(service).toBeTruthy();
  }));
});
