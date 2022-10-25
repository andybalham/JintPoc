function mapSecurityType(sourceType) {
  switch (sourceType) {
    case 0:
      return "Flat or Maisonette";
    default:
      return "Unknown";
  }
}

export { mapSecurityType }