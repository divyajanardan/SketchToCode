import { TestBed } from '@angular/core/testing';

import { SketchTocodeService } from './sketch-tocode.service';

describe('SketchTocodeService', () => {
  let service: SketchTocodeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SketchTocodeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
