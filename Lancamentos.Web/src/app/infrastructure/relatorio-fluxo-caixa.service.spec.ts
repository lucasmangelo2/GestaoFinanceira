import { TestBed } from '@angular/core/testing';

import { RelatorioFluxoCaixaService } from './relatorio-fluxo-caixa.service';

describe('RelatorioFluxoCaixaService', () => {
  let service: RelatorioFluxoCaixaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RelatorioFluxoCaixaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
