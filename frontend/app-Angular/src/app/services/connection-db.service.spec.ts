import { TestBed } from '@angular/core/testing';

import { ConnectionDbService } from './connection-db.service';

describe('ConnectionDbService', () => {
  let service: ConnectionDbService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConnectionDbService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
