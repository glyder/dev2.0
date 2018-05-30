import { TestBed, inject } from '@angular/core/testing';

import { SimulateHttpService } from './simulate-http.service';

describe('SimulateHttpService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SimulateHttpService]
    });
  });

  it('should be created', inject([SimulateHttpService], (service: SimulateHttpService) => {
    expect(service).toBeTruthy();
  }));
});
