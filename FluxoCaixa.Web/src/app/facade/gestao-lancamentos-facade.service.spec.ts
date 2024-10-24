import { TestBed } from '@angular/core/testing';

import { GestaoLancamentosFacadeService } from './gestao-lancamentos-facade.service';

describe('GestaoLancamentosFacadeService', () => {
  let service: GestaoLancamentosFacadeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GestaoLancamentosFacadeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
