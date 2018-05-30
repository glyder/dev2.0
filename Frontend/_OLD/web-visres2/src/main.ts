import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

import 'hammerjs';                          // NG-Material -> *HammerJS for gesture support

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic().bootstrapModule(AppModule)
  .then((success) => {
    // console.log(`Angular 5 Bootstrap success!`);

    // Alternative 2 to Service worker (not app.module.ts)
    // if ('serviceWorker' in navigator) {
    //   navigator.serviceWorker.register('/ngsw-worker.js') ;
    // }
  })
  .catch(err => console.log(err));
