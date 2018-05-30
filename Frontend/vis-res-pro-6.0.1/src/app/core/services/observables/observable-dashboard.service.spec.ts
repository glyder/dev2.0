import { TestBed, inject } from '@angular/core/testing';

import { ObservableDashboardService } from './observable-dashboard.service';

describe('ObservableDashboardService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ObservableDashboardService]
    });
  });

  it('should be created', inject([ObservableDashboardService], (service: ObservableDashboardService) => {
    expect(service).toBeTruthy();
  }));
});
