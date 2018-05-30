import { TestBed, inject } from '@angular/core/testing';

import { ObserverDashboardService } from './observer-dashboard.service';

describe('ObserverDashboardService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ObserverDashboardService]
    });
  });

  it('should be created', inject([ObserverDashboardService], (service: ObserverDashboardService) => {
    expect(service).toBeTruthy();
  }));
});
