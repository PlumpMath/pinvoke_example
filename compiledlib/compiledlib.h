#ifdef COMPILEDLIB_EXPORTS
#define COMPILEDLIB_API __declspec(dllexport)
#else
#define COMPILEDLIB_API __declspec(dllimport)
#endif

extern "C"
{
  COMPILEDLIB_API int addnumbers(int paramone, int paramtwo);
}
