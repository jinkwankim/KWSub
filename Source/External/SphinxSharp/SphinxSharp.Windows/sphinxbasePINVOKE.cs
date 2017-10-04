//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

class sphinxbasePINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="SWIGRegisterExceptionCallbacks_sphinxbase")]
    public static extern void SWIGRegisterExceptionCallbacks_sphinxbase(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_sphinxbase")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_sphinxbase(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_sphinxbase(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_sphinxbase(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(sphinxbasePINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(sphinxbasePINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="SWIGRegisterStringCallback_sphinxbase")]
    public static extern void SWIGRegisterStringCallback_sphinxbase(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_sphinxbase(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static sphinxbasePINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_Config")]
  public static extern void delete_Config(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_set_boolean")]
  public static extern void Config_set_boolean(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, bool jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_set_int")]
  public static extern void Config_set_int(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_set_float")]
  public static extern void Config_set_float(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, double jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_set_string")]
  public static extern void Config_set_string(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_set_string_extra")]
  public static extern void Config_set_string_extra(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_exists")]
  public static extern bool Config_exists(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_get_boolean")]
  public static extern bool Config_get_boolean(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_get_int")]
  public static extern int Config_get_int(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_get_float")]
  public static extern double Config_get_float(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Config_get_string")]
  public static extern string Config_get_string(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_FrontEnd")]
  public static extern global::System.IntPtr new_FrontEnd(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_FrontEnd")]
  public static extern void delete_FrontEnd(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FrontEnd_output_size")]
  public static extern int FrontEnd_output_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FrontEnd_start_utt")]
  public static extern void FrontEnd_start_utt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FrontEnd_process_utt")]
  public static extern int FrontEnd_process_utt(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, uint jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FrontEnd_end_utt")]
  public static extern int FrontEnd_end_utt(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_Feature")]
  public static extern global::System.IntPtr new_Feature(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_Feature")]
  public static extern void delete_Feature(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_FsgModel__SWIG_0")]
  public static extern global::System.IntPtr new_FsgModel__SWIG_0(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, float jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_FsgModel__SWIG_1")]
  public static extern global::System.IntPtr new_FsgModel__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_FsgModel__SWIG_2")]
  public static extern global::System.IntPtr new_FsgModel__SWIG_2(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, float jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_FsgModel")]
  public static extern void delete_FsgModel(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_word_id")]
  public static extern int FsgModel_word_id(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_word_add")]
  public static extern int FsgModel_word_add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_trans_add")]
  public static extern void FsgModel_trans_add(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_null_trans_add")]
  public static extern int FsgModel_null_trans_add(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_tag_trans_add")]
  public static extern int FsgModel_tag_trans_add(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_add_silence")]
  public static extern int FsgModel_add_silence(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, float jarg4);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_add_alt")]
  public static extern int FsgModel_add_alt(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_FsgModel_writefile")]
  public static extern void FsgModel_writefile(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_JsgfRule")]
  public static extern global::System.IntPtr new_JsgfRule();

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_JsgfRule")]
  public static extern void delete_JsgfRule(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_JsgfRule_fromIter")]
  public static extern global::System.IntPtr JsgfRule_fromIter(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_JsgfRule_name")]
  public static extern string JsgfRule_name(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_JsgfRule_public_")]
  public static extern bool JsgfRule_public_(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_fromIter")]
  public static extern global::System.IntPtr NGramModel_fromIter(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_NGramModel__SWIG_0")]
  public static extern global::System.IntPtr new_NGramModel__SWIG_0(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_NGramModel__SWIG_1")]
  public static extern global::System.IntPtr new_NGramModel__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_NGramModel")]
  public static extern void delete_NGramModel(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_write")]
  public static extern void NGramModel_write(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_str_to_type")]
  public static extern global::System.IntPtr NGramModel_str_to_type(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_type_to_str")]
  public static extern string NGramModel_type_to_str(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_casefold")]
  public static extern void NGramModel_casefold(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_size")]
  public static extern int NGramModel_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_add_word")]
  public static extern int NGramModel_add_word(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModel_prob")]
  public static extern int NGramModel_prob(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_LogMath__SWIG_0")]
  public static extern global::System.IntPtr new_LogMath__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_LogMath__SWIG_1")]
  public static extern global::System.IntPtr new_LogMath__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_LogMath")]
  public static extern void delete_LogMath(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_LogMath_exp")]
  public static extern double LogMath_exp(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSetIterator_ptr_set")]
  public static extern void NGramModelSetIterator_ptr_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSetIterator_ptr_get")]
  public static extern global::System.IntPtr NGramModelSetIterator_ptr_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_NGramModelSetIterator")]
  public static extern global::System.IntPtr new_NGramModelSetIterator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_NGramModelSetIterator")]
  public static extern void delete_NGramModelSetIterator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_JsgfIterator_ptr_set")]
  public static extern void JsgfIterator_ptr_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_JsgfIterator_ptr_get")]
  public static extern global::System.IntPtr JsgfIterator_ptr_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_JsgfIterator")]
  public static extern global::System.IntPtr new_JsgfIterator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_JsgfIterator")]
  public static extern void delete_JsgfIterator(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet___iter__")]
  public static extern global::System.IntPtr NGramModelSet___iter__(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_NGramModelSet")]
  public static extern global::System.IntPtr new_NGramModelSet(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_NGramModelSet")]
  public static extern void delete_NGramModelSet(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet_count")]
  public static extern int NGramModelSet_count(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet_add")]
  public static extern global::System.IntPtr NGramModelSet_add(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, string jarg3, float jarg4, bool jarg5);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet_select")]
  public static extern global::System.IntPtr NGramModelSet_select(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet_lookup")]
  public static extern global::System.IntPtr NGramModelSet_lookup(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_NGramModelSet_current")]
  public static extern string NGramModelSet_current(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Jsgf___iter__")]
  public static extern global::System.IntPtr Jsgf___iter__(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_new_Jsgf")]
  public static extern global::System.IntPtr new_Jsgf(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_delete_Jsgf")]
  public static extern void delete_Jsgf(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Jsgf_name")]
  public static extern string Jsgf_name(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Jsgf_get_rule")]
  public static extern global::System.IntPtr Jsgf_get_rule(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("SphinxNative.dll", EntryPoint="CSharp_Pocketsphinx_Jsgf_build_fsg")]
  public static extern global::System.IntPtr Jsgf_build_fsg(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, float jarg4);
}

}
