import { TestBed, async } from '@angular/core/testing';

// AppComponent
import { AppComponent } from './app.component';

import { NO_ERRORS_SCHEMA } from '@angular/core';

// MDBootstrap
import { ToastModule } from './typescripts/pro/alerts/toast/toast.module';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MDBBootstrapModule } from './typescripts/free';
import { MDBBootstrapModulePro } from './typescripts/pro/index';
import { AgmCoreModule } from '@agm/core';
import { MDBSpinningPreloader } from './typescripts/pro/index';

// Modules
import { CoreModule } from '@vrs/core/core.module';
import { SharedModule } from '@vrs/shared/shared.module';

// Components

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
      ],
      imports: [

        // Mdbootstrap
        BrowserModule,
        BrowserAnimationsModule,
        FormsModule,
        HttpModule,
        ToastModule.forRoot(),
        MDBBootstrapModule.forRoot(),
        MDBBootstrapModulePro.forRoot(),
        AgmCoreModule.forRoot({
          // https://developers.google.com/maps/documentation/javascript/get-api-key?hl=en#key
          apiKey: 'Your_api_key'
        }),

        // Modules
        CoreModule, SharedModule
      ],
      providers: [MDBSpinningPreloader],
      schemas:   [ NO_ERRORS_SCHEMA ]
    }).compileComponents();
  }));

  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));

  it(`should have as title 'app works!'`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('app works!');
  }));

  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h4').textContent).toContain('VisRes 2.0');
  }));
});
