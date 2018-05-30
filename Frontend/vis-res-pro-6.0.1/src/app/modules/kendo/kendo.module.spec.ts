import { KendoModule } from './kendo.module';

describe('KendoModule', () => {
  let kendoModule: KendoModule;

  beforeEach(() => {
    kendoModule = new KendoModule();
  });

  it('should create an instance', () => {
    expect(kendoModule).toBeTruthy();
  });
});
