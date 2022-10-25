import { mapSecurityType } from "./enumMappers.mjs";

function map(inputs) {
  const source = inputs.source;

  const output = {
    loanAmount: source.LoanAmount,
    nonExistantProp: source.my?.prop ?? "Nothing here but us chickens",
    security: {
      securityType: mapSecurityType(source.SecurityType),
      postcode: source.SecurityPostcode,
    },
  };

  return JSON.stringify(output);
}

export { map };
