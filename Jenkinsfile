pipeline {
    agent any

    environment {
        PYTHON_FILE = 'test_math_operations.py'
    }

    stages {
        stage('Installation') {
            steps {
                script {
                    sh "apt-get update && apt-get install -y python3"
                    sh "python3 -m pip install coverage"
                    sh "coverage --version"
                }
            }
        }

        stage('Run Test') {
            steps {
                script {
                    sh "coverage run ${PYTHON_FILE}"
                    sh "coverage report"
                    sh "coverage xml"
                }
            }
        }

        stage('Sonar Analysis') {
            steps {
                script {
                    def scannerHome = tool 'sonar-scanner'
                    withSonarQubeEnv('sonarcloud') {
                        sh """${scannerHome}/bin/sonar-scanner \
                        -D sonar.projectKey=cov-python \
                        -D sonar.projectName=cov-python \
                        -Dsonar.python.coverage.reportPaths=coverage.xml"""
                    }
                }
            }
        }
    }
}