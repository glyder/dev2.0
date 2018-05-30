// That's one big BARREL! - Brain Taylor

// https://angular.io/guide/glossary
// https://stackoverflow.com/questions/37564906/what-are-all-the-index-ts-used-for
//    A BARREL is a way to rollup exports from several modules
//    into a single convenience module. The barrel itself is a module
//    file that re-exports selected exports of other modules.

export * from './components';
export * from './interceptors';
export * from './modules';
export * from './core.module';
export * from './services';
