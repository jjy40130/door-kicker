# Door Kicker
> 귀여운 여우? 그리고 Unity Mono로 빌드된 게임을 분석하는 리버싱용 워게임 입니다.

[![NPM Version][npm-image]][npm-url]
[![Build Status][travis-image]][travis-url]
[![Downloads Stats][npm-downloads]][npm-url]

Unity Mono 기반으로 빌드된 워게임입니다. 게임이 정상적으로 진행되지 않는것이 정상이며, [Dreamhack 기준 레벨 2](https://dreamhack.io/wargame/challenges/523). 초중급 리버서용 리버싱 문제입니다.
당신은 해당 게임을 분석하고 패치하여 엔딩을 볼 수 있습니다. 문제에 대한 자세한 정보는 [여기](https://dreamhack.io/wargame/challenges/523)에서 확인하실 수 있습니다.

## 설치 방법

> 주의: 해당 문제는 윈도우즈 전용 문제입니다. 내부적으로 추가적인 DLL을 로드하기 때문에 윈도우즈 환경에서만 빌드하시길 추천드립니다.

`유니티[2020.3.3f1]에서 Mono 형식으로 빌드.` 혹은 [다운로드](https://dreamhack.io/wargame/challenges/523)

## 정보

[정재윤](https://github.com/jjy40130/) – [@디스코드](https://discordapp.com/users/276023356204122112) – jaeyun@alephstudio.xyz

`MIT` 라이센스를 준수하며 `LICENSE`에서 자세한 정보를 확인할 수 있습니다.

## 기여 방법

워게임에서 핵심적으로 사용되는 `CheckFlag.dll` 파일은 별도 소스코드가 공개되어 있지 않습니다.
추후 빠른 시일내에 정리하여 업로드 해두겠습니다.

1. [door-kicker](https://github.com/jjy40130/door-kicker/)를 포크합니다.
2. `git checkout -b feature/fooBar` 명령어로 새 브랜치를 만드세요.
3. `git commit -am 'Add some fooBar'` 명령어로 커밋하세요.
4. `git push origin feature/fooBar` 명령어로 브랜치에 푸시하세요. 
5. 풀리퀘스트를 보내주세요.

<!-- Markdown link & img dfn's -->
[npm-image]: https://img.shields.io/npm/v/datadog-metrics.svg?style=flat-square
[npm-url]: https://npmjs.org/package/datadog-metrics
[npm-downloads]: https://img.shields.io/npm/dm/datadog-metrics.svg?style=flat-square
[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://github.com/yourname/yourproject/wiki
