pipeline {
    agent any

    environment {
        PYTHON_FILE = 'path/to/test.py'
    }

    stages {
        
        stage('Checkout') {
            steps {
                script {
                    // Checkout the Git repository
                    checkout scm
                }
            }
        }

        stage('Installation') {
            steps {
                script {
                    // Install dependencies
                    sh "python3 -m pip install coverage"
                    sh "coverage --version"
                }
            }
        }

        stage('Run Test') {
            steps {
                script {
                    // Run tests and Generate reports
                    sh "pip install -r requirements.txt"
                    sh "coverage run ${PYTHON_FILE}"
                    sh "coverage report"
                    sh "coverage xml -o coverage.xml"
                }
            }
        }

        stage('Sonar Analysis') {
            environment {
                SCANNER_HOME = tool 'sonar_scanner_name'
                PROJECT_KEY = ''
                PROJECT_NAME = ''
            }
            steps {
                script {
                    withSonarQubeEnv('sonarcloud') {
                        sh """${SCANNER_HOME}/bin/sonar-scanner \
                        -D sonar.projectKey=${PROJECT_KEY} \
                        -D sonar.projectName=${PROJECT_NAME} \
                        -Dsonar.python.coverage.reportPaths=coverage.xml"""
                    }
                }
            }
        }
    }
}