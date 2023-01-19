import { TestBed } from '@angular/core/testing';

import { CodeProvidersService } from './code-providers.service';

describe('CodeProvidersService', () => {
  let service: CodeProvidersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CodeProvidersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
