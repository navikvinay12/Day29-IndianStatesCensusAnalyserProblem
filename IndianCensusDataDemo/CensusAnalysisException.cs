﻿using System.Runtime.Serialization;

namespace IndianCensusDataDemo
{
    public class CensusAnalyserException : Exception
    {
        public ExceptionType exception;

        public enum ExceptionType
        {
            FILE_NOT_FOUND, 
            INVALID_FILE_TYPE, 
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCOREECT_DELIMITER
        }
        public CensusAnalyserException(string message, ExceptionType exception) : base(message)
        {
            this.exception = exception;
        }
    }
}
