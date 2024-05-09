import { TestBed } from '@angular/core/testing';

import { CardActivityService } from './card-activity.service';

describe('CardActivityService', () => {
  let service: CardActivityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CardActivityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
