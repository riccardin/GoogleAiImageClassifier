# .NET Core Command-Line Image Classifier

This application uses the Google Cloud Vision API to analyze images and classify them into predefined categories: People, Technology, post-it, Faces, Feelings.

## Prerequisites

- .NET Core SDK
- Google Cloud Vision API credentials

## Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/githubnext/workspace-blank.git
    cd workspace-blank
    ```

2. Install the necessary NuGet packages:
    ```sh
    dotnet add package Google.Cloud.Vision.V1
    ```

3. Set up Google Cloud Vision API credentials:
    - Follow the instructions [here](https://cloud.google.com/vision/docs/setup) to set up your Google Cloud project and enable the Vision API.
    - Download the JSON key file for your service account.
    - Set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to the path of the JSON key file:
        ```sh
        export GOOGLE_APPLICATION_CREDENTIALS="path/to/your/credentials.json"
        ```

## Usage

To run the application, use the following command:
```sh
dotnet run -- path/to/your/image.jpg
```

## Example

```sh
dotnet run -- sample.jpg
```

The output will display the probabilities for each category:
```
People: 0.85
Technology: 0.10
post-it: 0.00
Faces: 0.75
Feelings: 0.60
```
