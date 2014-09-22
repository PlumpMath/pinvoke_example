#include "stdafx.h"
#include "compiledlib.h"

extern "C"
{
  COMPILEDLIB_API int addnumbers(int paramone, int paramtwo)
  {
    return paramone + paramtwo;
  }
}
