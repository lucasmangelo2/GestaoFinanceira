import { TestBed } from '@angular/core/testing';

import { GestaoLancamentosService } from './gestao-lancamentos.service';

describe('GestaoLancamentosService', () => {
  let service: GestaoLancamentosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GestaoLancamentosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
