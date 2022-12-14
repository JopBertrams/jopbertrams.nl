import { addMessages, init } from 'svelte-i18n';

import nl from './locales/nl.json';
import en from './locales/en.json';

addMessages('nl', nl);
addMessages('en', en);

init({
  fallbackLocale: 'nl',
  initialLocale: 'nl',
});
