# Roadmap — RoadProfit

## Em desenvolvimento

- [ ] Validação de entrada com método reutilizável (`LerDecimalPositivo`)
- [ ] Menu principal com módulos separados (Switch)
- [ ] Módulo Uber — cálculo do dia de trabalho
- [ ] Módulo Entregas — cálculo do dia com lógica própria

## Próximas fases

- [ ] Organização em classes — `JornadaUber`, `JornadaEntregas`
- [ ] Módulo Histórico — leitura e processamento de arquivo exportado via LGPD (Uber e 99)
- [ ] Sincronização incremental — importar só corridas ainda não registradas
- [ ] Relatório por período — dia, semana, mês
- [ ] Análise histórica — melhores dias, horários e médias ao longo do tempo

## Ideias futuras

- [ ] Cálculo de tempo produtivo vs tempo ocioso por dia
- [ ] Exportar relatório em arquivo (PDF ou CSV)
- [ ] Comparativo entre plataformas — Uber vs 99 vs Entregas

## Descartado

- ~~Automação do input via e-mail do Uber/99~~ — *substituído pela exportação de dados via LGPD*
