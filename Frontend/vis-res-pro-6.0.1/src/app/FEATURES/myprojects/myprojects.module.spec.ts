import { MyprojectsModule } from './myprojects.module';

describe('MyprojectsModule', () => {
  let myprojectsModule: MyprojectsModule;

  beforeEach(() => {
    myprojectsModule = new MyprojectsModule();
  });

  it('should create an instance', () => {
    expect(myprojectsModule).toBeTruthy();
  });
});
