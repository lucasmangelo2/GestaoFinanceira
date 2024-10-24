import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RelatorioFluxoCaixaComponent } from './relatorio-fluxo-caixa.component';

describe('RelatorioFluxoCaixaComponent', () => {
  let component: RelatorioFluxoCaixaComponent;
  let fixture: ComponentFixture<RelatorioFluxoCaixaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RelatorioFluxoCaixaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RelatorioFluxoCaixaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
