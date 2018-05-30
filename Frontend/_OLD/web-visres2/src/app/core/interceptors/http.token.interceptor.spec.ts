import { TestBed, inject } from '@angular/core/testing';

import { HttpTokenInterceptor } from './http.token.interceptor';

fdescribe('Http.TokenService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HttpTokenInterceptor]
    });
  });

  it('should be created', inject([HttpTokenInterceptor], (service: HttpTokenInterceptor) => {
    expect(service).toBeTruthy();
  }));
});
