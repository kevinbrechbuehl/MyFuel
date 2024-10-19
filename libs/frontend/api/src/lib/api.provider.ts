import {
  provideHttpClient,
  withInterceptorsFromDi,
} from '@angular/common/http';
import { EnvironmentProviders, importProvidersFrom } from '@angular/core';
import { ApiModule, Configuration } from './generated';

export function provideMyFuelApi(): EnvironmentProviders[] {
  return [
    provideHttpClient(withInterceptorsFromDi()),
    importProvidersFrom(ApiModule.forRoot(apiConfigFactory)),
  ];
}

function apiConfigFactory(): Configuration {
  return new Configuration({
    basePath: '',
  });
}
