import { Action } from '@ngrx/store';

export const SPANISH = 'SPANISH';
export const FRENCH = 'FRENCH';
export const AUSSIE = 'AUSSIE';

export function simpleReducer(state: string = 'Hello World', action: Action) {

  console.log(action.type, state);

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


export const INCREMENT = 'INCREMENT';
export const DECREMENT = 'DECREMENT';
export const RESET = 'RESET';

export function counterReducer(state: number = 0, action: Action) {
  switch (action.type) {
    case INCREMENT:
      return state + 1;

    case DECREMENT:
      return state - 1;

    case RESET:
      return 0;

    default:
      return state;
  }
}
