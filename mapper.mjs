import { mapSecurityType } from "./enumMappers.mjs";

function map(inputs) {
  const source = inputs.source;

  const output = {
    loanAmount: source.LoanAmount,
    security: {
      securityType: mapSecurityType(source.SecurityType),
      postcode: source.SecurityPostcode,
    },
  };

  return JSON.stringify(output);
}

export { map };
