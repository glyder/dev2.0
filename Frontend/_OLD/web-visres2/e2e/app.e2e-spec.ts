import { AppPage } from './app.po';
import { browser } from 'protractor';

function sleep() {
  // browser.driver.sleep(1500); // sleep for demonstration reasons
}

describe('VisRes2 App load', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('VisRes loads - H1 tag has VisRes ', () => {
    page.navigateTo();
    expect(page.getHomeTitle()).toEqual('VisRes');

    sleep();
  });

});
