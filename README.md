# ofxparser.net
OfxParser is a .NET library for working with Open Financial Exchange (OFX) data - both OFXv1 (SGML) and OFXv2 (pure XML) - which is the standard format for downloading financial information from banks and stockbrokers.

Example of usage:

Extract extrat = OFXParser.Parser.GenerateExtract(ofx);

if (extrat != null)
{
	foreach (var tran in extrat.Transactions)
	{

	}
}
