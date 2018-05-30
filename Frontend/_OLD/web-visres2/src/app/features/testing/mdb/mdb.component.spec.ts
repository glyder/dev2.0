import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';

import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { MdbComponent } from './mdb.component';


// From CORE Module
import { MDBBootstrapModule } from 'angular-bootstrap-md';

import { TestingRoutingModule } from '../testing-routing.module';


describe('MdbComponent', () => {
  let component: MdbComponent;
  let fixture: ComponentFixture<MdbComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbComponent ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
