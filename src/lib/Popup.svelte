<script>
  import { _ } from 'svelte-i18n';

  export let project = '';
</script>

<h1>{$_('projects.' + project + '.title')}</h1>
<img
  src={$_('projects.' + project + '.image')}
  alt="projectimage"
  width="80%"
  style="margin-left: auto; margin-right: auto; display: block;"
/>
<p>
  {$_('projects.' + project + '.description')}
</p>
