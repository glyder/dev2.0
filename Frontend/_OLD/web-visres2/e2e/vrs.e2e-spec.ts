import { VisResPage } from './vrs.po';
import { browser } from 'protractor';

function sleep() {
  // browser.driver.sleep(1500); // sleep for demonstration reasons
}

fdescribe('VisRes 2', () => {
  let page: VisResPage;

  beforeEach(() => {
    page = new VisResPage();
  });

  it('Home page loads up', () => {
    page.navigateTo('home');
    expect(page.getHomeTitle()).toEqual('VisRes');
    sleep();
  });

  it('Admin loads up', () => {
    page.navigateTo('admin');

    expect(page.getByTagName('admin')).toBeTruthy();
    // expect(page.getPageMDBElements()).toBe('mdb works!');
    // expect(page.getPageMDBElements().count()).toBe('mdb works!');
    sleep();
  });

  it('Dashboard loads up', () => {
    page.navigateTo('dashboard');
    expect(page.getByTagName('dashboard')).toBeTruthy();
    sleep();
  });

  it('Maintenance loads up', () => {
    page.navigateTo('maintenance');
    expect(page.getByTagName('maintenance')).toBeTruthy();
    sleep();
  });

  it('Reports loads up', () => {
    page.navigateTo('reports');
    expect(page.getByTagName('reports')).toBeTruthy();
    sleep();
  });

  it('Search loads up', () => {
    page.navigateTo('search');
    expect(page.getByTagName('search')).toBeTruthy();
    sleep();
  });

  it('Bootrstrap loads up', () => {
    page.navigateTo('bootstrap');
    expect(page.getByTagName('bootstrap')).toBeTruthy();
    sleep();
  });

  it('Material loads up', () => {
    page.navigateTo('material');
    expect(page.getByTagName('material')).toBeTruthy();
    sleep();
  });

  it('Mdb loads up', () => {
    page.navigateTo('mdb');
    expect(page.getByTagName('mdb')).toBeTruthy();
    sleep();
  });

  // it('should open and view a particular pokemon', () => {
  //   page.navigateTo();
  //   page.getFirstPokemonCardElement().click();

  //   expect(page.getOpenModalElement()).toBeTruthy();
  //   expect(page.getOpenModalHeadingElement().getText()).toBe('Bulbasaur #1');
  //   sleep();
  // });

  // it('should open and allow arrow keys to navigate between pokemon', () => {
  //   page.navigateTo();
  //   page.getFirstPokemonCardElement().click();
  //   page.selectNextKey();

  //   expect(page.getOpenModalHeadingElement().getText()).toBe('Ivysaur #2');
  //   sleep();

  //   page.selectPrevKey();
  //   page.selectPrevKey();
  //   expect(page.getOpenModalHeadingElement().getText()).toBe('Mew #151');
  //   sleep();
  // });

});
