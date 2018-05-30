import { Action } from '@ngrx/store';

export const SPANISH = 'SPANISH';
export const FRENCH = 'FRENCH';
export const AUSSIE = 'AUSSIE';

export function simpleReducer(state: string = 'Hello World', action: Action) {
  // console.log(action.type, state);

  switch (action.type) {
    case SPANISH:
      return state = 'Hola Mundo';

    case FRENCH:
      return state = 'Bonjour le monde';

    case AUSSIE:
      return state = 'Hello World!!!';

    default:
      return state;
  }
}


export const SIMPLE_INCREMENT = '[Simple] INCREMENT';
export const SIMPLE_DECREMENT = '[Simple] DECREMENT';
export const SIMPLE_RESET = '[Simple] RESET';


export function counterReducer(state: number = 0, action: Action) {

  switch (action.type) {

    case SIMPLE_INCREMENT:
      return state + 1;

    case SIMPLE_DECREMENT:
      return state - 1;

    case SIMPLE_RESET:
      return 0;

    default:
      return state;

  }
}
