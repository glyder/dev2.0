// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.

export const environment = {
  production: false,

  envName: 'Staged',

  appApi: {
    baseUrl: 'http://localhost:65464/api',
    webApi: 'http://localhost:65464/api'
  },
  // api_url: 'https://conduit.productionready.io/api',
  // api_url2: 'http://localhost:3333/api',

  animal: '🐔',
  person: '👶'

};



// Local
// Staged
// Production
