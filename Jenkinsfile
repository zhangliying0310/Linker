 Pipeline{
     agent{
         label 'dotnet'
     }

     parameters{
         string(name: 'BAGRT_URL',defaultValue: 'http://localhost:5555/v3/index.json',description:'where is upload baget')
     }
     stages{
         stage('Compile'){
             steps{
                sh './build.sh build.cake --target=Complile'
             } 
         }
         stage('Build-Frontend'){
             steps{
                sh './build.sh build.cake --target=Build-Frontend'
             } 
         }
         stage('Test'){
             steps{
                sh './build.sh build.cake --target=Test'
             } 
         }
         stage('Version'){
             steps{
                sh './build.sh build.cake --target=Version'
             } 
         }
         stage('Deploy'){
             steps{
                echo 'Deploying......'
             } 
         }
     }
 }

