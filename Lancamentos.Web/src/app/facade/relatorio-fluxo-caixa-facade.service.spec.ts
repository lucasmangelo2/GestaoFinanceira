import { TestBed } from '@angular/core/testing';

import { RelatorioFluxoCaixaFacadeService } from './relatorio-fluxo-caixa-facade.service';

describe('RelatorioFluxoCaixaFacadeService', () => {
  let service: RelatorioFluxoCaixaFacadeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RelatorioFluxoCaixaFacadeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
