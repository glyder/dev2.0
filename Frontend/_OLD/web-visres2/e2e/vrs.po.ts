import { browser, by, element, Key } from 'protractor';

export class VisResPage {

  navigateTo(page: string) {
    switch (page) {
      case 'home':
        return browser.get('/');
      case 'admin':
        return browser.get('/feature-admin');
      case 'dashboard':
        return browser.get('/feature-dashboard');
      case 'maintenance':
        return browser.get('/feature-maintenance');
      case 'reports':
        return browser.get('/features-reports');
      case 'search':
        return browser.get('/features-search');
      case 'boostrap':
        return browser.get('/testing/bootstrap');
      case 'material':
        return browser.get('/testing/material');
      case 'mdb':
        return browser.get('/testing/mdb');
      default:
        return browser.get('/');
    }
  }


  getHomeTitle() {
    return element(by.css('app-root h1')).getText();
  }

  // getParagraphText() {
  //   return element(by.css('app-root h1')).getText();
  // }

  // Tag Name
  // ====================================================
  getByTagName(page: string) {
    switch (page) {
      case 'home':
        return element(by.tagName('app-root'));
      case 'admin':
        return element(by.tagName('app-admin'));
      case 'dashboard':
        return element(by.tagName('app-dashboard'));
      case 'maintenance':
        return element(by.tagName('app-maintenance'));
      case 'reports':
        return element(by.tagName('app-reports'));
      case 'search':
        return element(by.tagName('app-search'));
      case 'bootstrap':
        return element(by.tagName('app-bootstrap'));
      case 'material':
        return element(by.tagName('app-material'));
      case 'mdb':
        return element(by.tagName('app-mdb'));
      default:
        return element(by.tagName('app-root'));
    }
  }


  // CSS Keys
  // ====================================================
  getPageMDBElements() {
    // return element.all(by.css('mdb-title'));
    // return element(by.css('mdb-title')).getText();
    return element(by.tagName('app-mdb'));
  }

  // getPokemonCardElements() {
  //   return element.all(by.css('.card--media'));
  // }

  // getFirstPokemonCardElement() {
  //   return element(by.css('.card--media'));
  // }

  // getOpenModalElement() {
  //   return element(by.tagName('app-modal'));
  // }

  // getOpenModalHeadingElement() {
  //   return element(by.css('app-modal h1'));
  // }

  // Keys
  // ====================================================
  selectNextKey() {
    browser.actions().sendKeys(Key.ARROW_RIGHT).perform();
  }

  selectPrevKey() {
    browser.actions().sendKeys(Key.ARROW_LEFT).perform();
  }

  selectEscapeKey() {
    browser.actions().sendKeys(Key.ESCAPE).perform();
  }
}
