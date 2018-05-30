import { MdbModule } from './mdb.module';

describe('MdbModule', () => {
  let mdbModule: MdbModule;

  beforeEach(() => {
    mdbModule = new MdbModule();
  });

  it('should create an instance', () => {
    expect(mdbModule).toBeTruthy();
  });
});
